namespace SurfBoardApi.Services
{
    public class VolumePranchaService
    {
        public static double CalcularVolume(double peso, string nivelExperiencia)
        {
            return nivelExperiencia.ToLower() switch
            {
                "iniciante" => peso * 0.6,
                "intermediário" => peso * 0.5,
                "avançado" => peso * 0.4,
                _ => throw new ArgumentException("Nível de Experiência inválido.")
            };
        }
    }
}
