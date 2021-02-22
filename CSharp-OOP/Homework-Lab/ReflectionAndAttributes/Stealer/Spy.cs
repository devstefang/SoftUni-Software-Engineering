using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
   public class Spy
    {
        public string StealFieldInfo(string classToInvestigate, params string[] namesOfFields)
        {
            Type classType = Type.GetType(classToInvestigate);
            FieldInfo[] classFields = classType.GetFields(BindingFlags.Public |
                   BindingFlags.Instance |
                   BindingFlags.Static |
                   BindingFlags.NonPublic);
            StringBuilder sb = new StringBuilder();
            Object classInstance = Activator.CreateInstance(classType, new object[] { });
            sb.AppendLine($"Class under investigation: {classToInvestigate}");
            foreach (FieldInfo field in classFields.Where(f=> namesOfFields.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }
            return sb.ToString().TrimEnd();
        }
        public string AnalyzeAcessModifiers(string className)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] publicFieldInfo = classType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] privateMethodInfo = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            MethodInfo[] publicMethodInfo = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            foreach (var field in publicFieldInfo)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach (var privateMethod in privateMethodInfo.Where(m=>m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{privateMethod.Name} have to be public!");
            }
            foreach (var publicMethod in publicMethodInfo.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{publicMethod.Name} have to be private!");
            }
            return sb.ToString().TrimEnd();
        }
        public string RevealPrivateMethods(string className)
        {
            Type classType = Type.GetType(className);
            MethodInfo[] privateMethodInfo = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base Class: {classType.BaseType.Name}");
            foreach (var privateMethod in privateMethodInfo)
            {
                sb.AppendLine(privateMethod.Name);
            }
            return sb.ToString().TrimEnd();
        }
        public string CollectGetterAndSetters(string className)
        {
            Type classType = Type.GetType(className);
            MethodInfo[] methodsInfo = classType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            StringBuilder sb = new StringBuilder();
            foreach (var getters in methodsInfo.Where(m=>m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{getters.Name} will return {getters.ReturnType}");
            }
            foreach (var setters in methodsInfo.Where(m=>m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{setters.Name} will return {setters.ReturnType}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
