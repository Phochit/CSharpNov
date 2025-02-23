// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Reflection.Emit;

namespace Reflection2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Emit Method
            //AssemblyName aname = new AssemblyName("MyEmit");

            //AssemblyBuilder abuilder = AssemblyBuilder.DefineDynamicAssembly(aname,
            //                            AssemblyBuilderAccess.Run);

            //// Module
            //ModuleBuilder mb = abuilder.DefineDynamicModule("MainModule");

            //TypeBuilder tb = mb.DefineType("Widget", TypeAttributes.Public);

            //MethodBuilder met = tb.DefineMethod("SquareRoot",
            //                    MethodAttributes.Static | MethodAttributes.Public,
            //                    CallingConventions.Standard,
            //                    typeof(double), // return type
            //                    new[] { typeof(double) }); // parrameter

            //met.DefineParameter(1, ParameterAttributes.None, "value");

            //ILGenerator il = met.GetILGenerator();
            //il.Emit(OpCodes.Ldarg_0);
            //il.Emit(OpCodes.Call, typeof(Math).GetMethod("Sqrt"));
            //il.Emit(OpCodes.Ret);


            //Type realType = tb.CreateType();
            //double x =(double) tb.GetMethod("SquareRoot").Invoke(null, new object[] { 2 });

            //Console.WriteLine(x);

            #endregion

            #region Dynamic Method

            //var dyMethod=new DynamicMethod("Greeting",null,null,typeof(Person));
            //ILGenerator il = dyMethod.GetILGenerator();
            //il.EmitWriteLine("Hello ITC");
            //il.Emit(OpCodes.Ret);
            //dyMethod.Invoke(null,null);

            #endregion

            #region Private Method Call

            var dyMethod=new DynamicMethod("CallPrivate",null,null,typeof(Person));
            ILGenerator il = dyMethod.GetILGenerator();

            MethodInfo pm = typeof(Person).GetMethod("ShowName",
                            BindingFlags.Static | BindingFlags.NonPublic);

            il.Emit(OpCodes.Call, pm);
            il.Emit(OpCodes.Ret);

            dyMethod.Invoke(null, null);

            #endregion

            #region Get Members

            var members=typeof(Person)
                    .GetMembers( BindingFlags.Static 
                    | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            foreach (var member in members.Where(m=> ! m.DeclaringType.ToString().Contains("System")
                                           && m.MemberType.ToString()!="Constructor" ))
            {
                Console.WriteLine( $"{member.Name} | {member.MemberType} | {member.DeclaringType}" );
            }

            #endregion

            // EMP_IT_00001
            // EMP_FN_00001

            // [A-Z]_[A-Z]_[0-9](5)

            // w@w.w

            // myasp.net , smarterasp.net
        }

    }

    class Person
    {
        public string Person_Name { get; set; }

        public string Person_ID { get; set; }
        static void ShowName() // public,private,internal,protected
        {
            Console.WriteLine("ABCDEFG");
        }

        
    }
}


