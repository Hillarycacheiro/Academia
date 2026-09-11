namespace Academia;

public class Plano
{
    public int Id {get; set;}
    public string Nome {get; set;} // Nome do plano , = string.Empty significa valor vazio.
    public decimal ValorMensal {get; set;} // Valor da mensalidade do plano
    public int DuracaoMeses {get; set;} // Duracao do plano em meses
    public List<Matricula>? Matriculas {get; set;} // Lista de matriculas associadas ao plano
}