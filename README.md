# younder-test

Aplicação proposta para o teste da Younder<br />
<br />
Younder: Analista de Desenvolvimento. <br />
Este é um teste técnico para o cargo de Analista de Desenvolvimento. O objetivo é avaliar a sua capacidade de solucionar problemas, portanto é importante que você faça esse teste sozinho. Não tenha medo de errar, não existem soluções iguais e perfeitas.<br />
<br />
Instruções <br />
O foco do teste é a criação de um CRUD simples e Arquitetura, o teste deve ser desenvolvido utilizando boas práticas e empregando o seu conhecimento. (nos envie a solução compactada, orientando como executá-la).<br />
<br />
<br />
Teste:<br /> 
Desenvolver uma tela onde seja possível consultar, cadastrar, alterar e excluir dados de uma tabela simples de Clientes.<br />
<br />
Ferramentas desejadas para o desenvolvimento: <br />

<ul>
<li>“Angular JS / Angular 2+ ou React”.</li>
<li>Desenvolver WebAPI para consumo das informações utilizando “.Net C#”.</li>
<li>Acesso aos dados utilizando ORM de sua escolha.</li>
</ul>
<br />
#Observações<br />
Utilizei Visual Studio 2015 para desenvolver a api em .Net C#<br />
React para UI<br />
MongoDB como banco de dados<br />
MongoDrive como ORM (Tive alguns problemas com a minha máquina e o sql, então, não pude seguir com o entity framework)<br />

#Configurando para testar

Instalar MongoDB 4.0.17 
  Fazer instalação padrão

Após instalação do MongoDB
  Executar os seguintes comandos
    > md "C:/mongodb/"
    > cd "C:/program files/mongodb/server/4.0/bin"
    > mongod.exe --dbpath C:/mongodb/
  Tradução dos comandos:
    - criar uma pasta chamada mongodb no disco C:
    - acessar a pasta onde está o configurador do mongodb
    - configura o mongodb na pasta criada anteriormente (C:/mongodb/)

Possívelmente o mongodb estará rodando na porta padrão localhost:27017

Ao clonar o repositório.
  ♦ Abrir o arquivo younder-test/WebApp.sln no visual studio 2015
  ♦ Configurar o Web.config da aplicação WebApp.Api 
    configuration>connectionStrings
      configurar a connectionString para o localhost que o mongodb estiver rodando
      caso o seu mongodb esteja rodando na porta padrão, não será necessário modificar
      Chave da porta padrão: <add name="database" connectionString="mongodb://localhost:27017/" />
  ♦ Configurar o projeto WebApp.Api para executar na porta localhost:11145
  ♦ Executar aplicação (F5) 
    Ao executar, o nuget deve restaurar os pacotes automáticamente.
  
  ♦ Abrir younder-test\WebApp.UI no CMD
    Caso a api não esteja rodando na porta localhost:11145
      Abrir o arquivo younder-test\WebApp.UI\src\services\api.js
      Modificar 'http://localhost:11145' para o localhost que a api está executando
    executar os comandos:
      > npm install
      O comando vai instalar todas as dependências da aplicação web
      > npm start
      O comando vai iniciar a aplicação Web em http://localhost:3000
    Páginas existentes:
      http://localhost:3000/cliente/list
      http://localhost:3000/cliente/new
      http://localhost:3000/cliente/edit
      
      
      
      
      
