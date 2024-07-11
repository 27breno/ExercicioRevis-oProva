using ExercicioRevisãoProva;


Automovel a = new Automovel();
a.Marca = "Mitsubishi";
a.Modelo = "GTR-Skilyne";
a.Cor = "preto-fosco";
a.Placa = "13V27F4";


Funcionario f = new Funcionario ("Breno", 132445, "2A3892Q");

f.ValorMaticula();
f.VerificarVeiculo(a);

Pessoa p = new Pessoa ("Breno");
p.contratar();