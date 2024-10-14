using CoPick.Setting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public class CameraCommunicationManager
    {
        public static readonly List<Type> SupportedCameraCommunicators = GetSupportedCameraCommunicators();

        private static List<Type> GetSupportedCameraCommunicators()
        {
            Type typeFromHandle = typeof(ICameraCommunicator);
            List<Type> list = new List<Type>();
            try
            {
                string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*Communicator.dll");
                for (int i = 0; i < files.Length; i++)
                {
                    Assembly.LoadFrom(files[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something wrong with loading Camera Communicator.dll files...(" + ex.Message + ") Anyway we could continue");
            }

            try
            {
                Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
                for (int i = 0; i < assemblies.Length; i++)
                {
                    Type[] types = assemblies[i].GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.Name.Contains("Communicator"))
                        {
                            Console.WriteLine($"{type.Name} :{typeFromHandle.IsAssignableFrom(type)} || {!type.IsInterface} || {!type.IsAbstract}");
                        }
                        if (typeFromHandle.IsAssignableFrom(type) && !type.IsInterface && !type.IsAbstract)
                        {
                            list.Add(type);
                        }
                    }
                }
            }
            catch (ReflectionTypeLoadException ex3)
            {
                Exception[] loaderExceptions = ex3.LoaderExceptions;
                for (int i = 0; i < loaderExceptions.Length; i++)
                {
                    Console.WriteLine(loaderExceptions[i].Message);
                }
            }
            catch (Exception arg)
            {
                Console.WriteLine($"Something wrong with loading Camera Communicators from CurrentDomain Assemblies..{arg}");
            }

            return list;
        }

        public static ICameraCommunicator CreateCameraCommunicator(Type typeOfCameraCommunicator, Dictionary<Camera2DAttribute, string> CameraConfig)
        {
            try
            {
                return (ICameraCommunicator)Activator.CreateInstance(typeOfCameraCommunicator, CameraConfig);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static ICameraCommunicator CreateCameraCommunicator(string typeNameOfCameraCommunicator, Dictionary<Camera2DAttribute, string> CameraConfig)
        {
            Type type = SupportedCameraCommunicators.Find((Type x) => x.Name == typeNameOfCameraCommunicator);
            if (type != null)
            {
                return CreateCameraCommunicator(type, CameraConfig);
            }

            return null;
        }
    }
}
