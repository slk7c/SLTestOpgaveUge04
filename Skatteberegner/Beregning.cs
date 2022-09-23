namespace Skatteberegner
{
    public class Beregning
    {
        private const double JULEGAVE_BESKATNING = 900;
        private const double BAGATELGRAENSE = 1200;

        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave)
        {
            var total = julegave + andenGave;

            return (julegave, total) switch
            {
                ( <= JULEGAVE_BESKATNING, > BAGATELGRAENSE) => andenGave,
                ( > JULEGAVE_BESKATNING, > BAGATELGRAENSE) => total,
                _ => 0
            };
        }
    }
}