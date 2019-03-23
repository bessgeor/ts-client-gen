using System;

namespace TSClientGen.ApiDescriptors
{
	/// <summary>
	/// Descriptor for writing TypeScript interface generated from a .net type 
	/// </summary>
	public class InterfaceDescriptor : BaseTypeDescriptor
	{
		/// <summary>
		/// ctor
		/// </summary>
		public InterfaceDescriptor(Type type, Type baseType): base(type)
		{
			BaseType = baseType;
		}
		
		/// <summary>
		/// Конструктор для генерации базового ts-интерфейса 
		/// (того, на котором висит <see cref="TypeScriptTypeAttribute"/> с <see cref="TypeScriptTypeAttribute.InheritedTypes"/>)
		/// </summary>
		public InterfaceDescriptor(Type type, Type discriminatorFieldType, string discriminatorFieldName, Type baseType) : base(type)
		{
			DiscriminatorFieldType = discriminatorFieldType;
			DiscriminatorFieldName = discriminatorFieldName;
			BaseType = baseType;
		}
		
		
		/// <summary>
		/// Тип свойства-дискиминатора
		/// </summary>
		public Type DiscriminatorFieldType { get; }
		
		/// <summary>
		/// Название свойства-дискриминатора 
		/// </summary>
		public string DiscriminatorFieldName { get; }

		/// <summary>
		/// Базовый класс для генерируемого <see cref="Type"/>
		/// </summary>
		public Type BaseType { get; }		
	}
}