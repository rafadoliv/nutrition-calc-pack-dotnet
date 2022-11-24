# health-calc-pack-dotnet
## Curso de Pós-Graduação em Engenharia de Software da PUC-MG
Aluno: Rafael de Oliveira

### Disciplina Projeto Integrado em Engenharia de Software

Objetivo: 

Uma biblioteca que permite cálculo de IMC e Macronutrientes, baseados nos dados inseridos pelo usuário.

# Utilização / Versionamento:

###**Version: 1.0.0:**
 
 *Instanciar um novo objeto do tipo IMC para em seguida utilizar os métodos disponiveis na versão:* 

### Methodos disponiveis > 
- Calc (Responsável por retornar o número IMC)
  - Parâmetros: Altura(Tipo Double) e Peso(Tipo Double)
  - Exemplo return Double RetornoIMC = ObjectIMC.Calc(Altura ,Peso);
- IsValidData (Responsável validar os dados informados)
  - Parametros: Altura(Tipo Double) e Peso(Tipo Double)
  - Exemplo: return bool RetornoIMC = ObjectIMC.IsValidData(Altura,Peso);
- GetIMCClass (Respponsavel por retornar a classe que o individo se encontra)
  - Parametros: IMC(Double)
  - Exemplo: return string RetornoIMC = ObjectIMC.GetIMCClass(IMC);

###**Version: 1.1.0:**
-Adição código macronutrientes
-Adição dos arquivos:
 - NivelAtividadeFisicaEnum.cs
 - NivelAtividadeFisicaEnum.cs
 - Sexo.cs
 - IMacronutrienteModel.cs
 - MacronutrienteModel.cs
-Criação do Teste Final:
 - MacronutrienteTest.cs

- Geração do Nuget Final
-Comando:
 dotnet add package health-calc-pack-dotnet-Rafael-de-Oliveira --version 1.1.0

# Arquitetura

<img src='nutrition-calc-diagram.jpg' alt='Diagrama'>

# Tecnologias Utilizadas

- IDE

  - [Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/)

- Framework

  - .NET 6.0

- Testing

  - [XUnit.net](https://xunit.net/)

- Distribuição

  - [NuGet](https://www.nuget.org/)

