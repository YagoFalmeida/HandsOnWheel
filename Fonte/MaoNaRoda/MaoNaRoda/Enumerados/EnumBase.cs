using System.ComponentModel;

namespace MaoNaRoda.Enumerados
{
    public class EnumBase
    {
        public static string GetDescricao<T>(string enumValue)
        {
            try
            {
                DescriptionAttribute? descricaoAtributo = typeof(T)
                                                        .GetField(enumValue)
                                                        .GetCustomAttributes(typeof(DescriptionAttribute), false)
                                                        .FirstOrDefault() as DescriptionAttribute;

                return descricaoAtributo != null ? descricaoAtributo.Description : enumValue;
            }
            catch(Exception ex)
            {
                throw new Exception($"Falha ao obter descrição: {ex.Message}");
            }           
        }
    }
}
