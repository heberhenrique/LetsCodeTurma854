var estadoAprovado = "Aprovado";
var estadoReprovado = "Aprovado";

int statusAluno = 3;
StatusAluno statusAluno2 = StatusAluno.Aprovado;

if (statusAluno == 1)
{
    //
}
else if (statusAluno == 2)
{
    //
}

switch (statusAluno2)
{
    case StatusAluno.Aprovado:
        break;
    case StatusAluno.Reprovado:
        break;
    case StatusAluno.NaoFezAProva:
        break;
    default:
        break;
}

Console.WriteLine((StatusAluno)statusAluno);

enum StatusAluno
{
    Aprovado = 1,
    Reprovado = 5,
    NaoFezAProva = 6
}


