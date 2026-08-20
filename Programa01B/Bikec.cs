namespace Programa01B
{
    class Bikec
    {
        //Declarações
        public string? Modelo { get; set; }
        public double Bateria { get; set; }
        public double PesoCiclista { get; set; }
        public int RecargaMes { get; set; }


        //METÓDOS(AÇÕES0
        public double CalcularAutonomia()
        {
            double autonomiaBase = Bateria /15.0;
            bool peso = PesoCiclista > 90.0;
            //se o peso for mais de 90 kg
            return peso ? (autonomiaBase * 0.05) : autonomiaBase;
        }

        public double CalcularConsumoMensal()
        {
            double cargaPorKm = Bateria / 1000.0;
            return cargaPorKm * RecargaMes;
        }

        public double CalcularCustoMensal()
        {
            const double PRECO = 0.80;
            return CalcularConsumoMensal() * PRECO;
        }

        public bool BikeEconomica()
        {
            return (CalcularCustoMensal() < 15.00) || (CalcularAutonomia() > 40.0);
        }

    }
}
