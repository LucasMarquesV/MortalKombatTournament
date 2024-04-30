<h2 align="center" > Projeto Final -🥊 Torneio </h2>

<p align="center">Torneio referente a ultima semana do plano de estágio da T-Systems. Personagens do jogo de luta Mortal Kombat utilizados. </p> 
<h3 align="center">  <img src="https://img.shields.io/badge/Estado-Estável-Green"></h3>


<!-- Sobre -->
<h2> Sobre o projeto: </h2>

Utilizei dos personagens de Mortal Kombat e da ideia solicitada pela regra de negócio pré determinada da semana para desenvolver o WEB APP. 
<h3> Imagem da tela de seleção</h3>
<img src="img-readme/selecao.png">

## Preparação

1º) Restaure o banco de dados, há um arquivo na pasta  'Data - arquivo .bak' utilizando o SQL Server MS.<br/>
2º) Altere a Connection string no metodo builder da  `Program.cs`, utilizando os dados do SQL Server, desta forma:

```csharp
builder.Services.AddEntityFrameworkSqlServer().AddDbContext<ContextoBase>
    (x => x.UseSqlServer("Server=<Nome_do_servidor>; Database = DB_Lutadores; Integrated Security = True; TrustServerCertificate = True"));
  
Exemplo:

builder.Services.AddEntityFrameworkSqlServer().AddDbContext<ContextoBase>
    (x => x.UseSqlServer("Server = CTS1A519661\\SQLEXPRESS; Database = DB_Lutadores; Integrated Security = True; TrustServerCertificate = True"));

```
3º) Após clonar o projeto na máquina local, abra o projeto com o Visual Studio e execute.


</p>

<h2 align="left"> Ferramentas e tecnologias usadas:</h2>
<p align="left"> <a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a> <a href="https://www.w3schools.com/css/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/css3/css3-original-wordmark.svg" alt="css3" width="40" height="40"/> </a> <a href="https://www.w3.org/html/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/html5/html5-original-wordmark.svg" alt="html5" width="40" height="40"/> </a> <a href="https://developer.mozilla.org/en-US/docs/Web/JavaScript" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/javascript/javascript-original.svg" alt="javascript" width="40" height="40"/> </a> </p>

