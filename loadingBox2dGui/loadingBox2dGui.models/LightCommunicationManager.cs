using CoPick.Plc;
using CoPick.Setting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace loadingBox2dGui.models
{
    public static class LightCommunicationManager
    {
        public static readonly List<Type> SupportedLightCommunicators = GetSupportedLightCommunicators();

        private static List<Type> GetSupportedLightCommunicators()
        {
            Type typeFromHandle = typeof(ILightCommunicator);
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
                Console.WriteLine("Something wrong with loading Light Communicator.dll files...(" + ex.Message + ") Anyway we could continue");
            }

            try
            {
                string[] files = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs"), "*Communicator.dll");
                for (int i = 0; i < files.Length; i++)
                {
                    Assembly.LoadFrom(files[i]);
                }
            }
            catch (Exception ex2)
            {
                Console.WriteLine("Something wrong with loading Light Communicator.dll files(libs)...(" + ex2.Message + ") Anyway we could continue");
            }

            try
            {
                Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
                for (int i = 0; i < assemblies.Length; i++)
                {
                    Type[] types = assemblies[i].GetTypes();
                    foreach (Type type in types)
                    {
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
                Console.WriteLine($"Something wrong with loading Light Communicators from CurrentDomain Assemblies..{arg}");
            }

            return list;
        }

        public static ILightCommunicator CreateLightCommunicator(Type typeOfLightCommunicator, Dictionary<ModbusAttribute, string> LightConfig)
        {
            try
            {
                return (ILightCommunicator)Activator.CreateInstance(typeOfLightCommunicator);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static ILightCommunicator CreateLightCommunicator(string typeNameOfLightCommunicator, Dictionary<ModbusAttribute, string> LightConfig)
        {
            Type type = SupportedLightCommunicators.Find((Type x) => x.Name == typeNameOfLightCommunicator);
            if (type != null)
            {
                return CreateLightCommunicator(type, LightConfig);
            }

            return null;
        }
    }
}
