//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static unsafe partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct Employee
        {
            private class struct_value
            {
                // Field instance values
                //public DateTime When;
                //public string What = "";
            }

            private readonly struct_value _value;
            
            public Employee(NilType _)
            {
                _value = new struct_value();
                // Inherited interface initializations
                // Inherited structure initializations
            }

            // Only include constructor if struct contains fields
            //public Employee(params)
            //{
            //    _value = new struct_value
            //    {
            //       Field = Field,
            //    };
            //    // Inherited interface initializations
            //    // Inherited structure initializations
            //}

            // Enable comparisons between nil and Employee struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Employee value, NilType nil) => value.Equals(default(Employee));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Employee value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Employee value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Employee value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Employee(NilType nil) => default(Employee);
        }
    }
}