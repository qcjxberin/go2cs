//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 July 05 21:01:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct PeopleByShoeSize
        {
            // Value of the PeopleByShoeSize struct
            private readonly Slice<Person> m_value;

            public PeopleByShoeSize(Slice<Person> value) => m_value = value;

            // Enable implicit conversions between Slice<Person> and PeopleByShoeSize struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PeopleByShoeSize(Slice<Person> value) => new PeopleByShoeSize(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Slice<Person>(PeopleByShoeSize value) => value.m_value;
            
            // Enable comparisons between nil and PeopleByShoeSize struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(PeopleByShoeSize value, NilType nil) => value.Equals(default(PeopleByShoeSize));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(PeopleByShoeSize value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, PeopleByShoeSize value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, PeopleByShoeSize value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator PeopleByShoeSize(NilType nil) => default(PeopleByShoeSize);
        }
    }
}
