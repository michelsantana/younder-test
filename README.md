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
<br />
<pre>
#Configurando para testar<br />

Instalar MongoDB 4.0.17
&nbsp;&nbsp;Fazer instalação padrão

Após instalação do MongoDB
&nbsp;&nbsp;Executar os seguintes comandos
&nbsp;&nbsp;&nbsp;&nbsp;> md "C:/mongodb/"
&nbsp;&nbsp;&nbsp;&nbsp;> cd "C:/program files/mongodb/server/4.0/bin"
&nbsp;&nbsp;&nbsp;&nbsp;> mongod.exe --dbpath C:/mongodb/
&nbsp;&nbsp;Tradução dos comandos:
&nbsp;&nbsp;&nbsp;&nbsp;- criar uma pasta chamada mongodb no disco C:
&nbsp;&nbsp;&nbsp;&nbsp;- acessar a pasta onde está o configurador do mongodb
&nbsp;&nbsp;&nbsp;&nbsp;- configura o mongodb na pasta criada anteriormente (C:/mongodb/)

Possívelmente o mongodb estará rodando na porta padrão localhost:27017

Ao clonar o repositório.&nbsp;&nbsp;&nbsp;&nbsp;&n&nbsp;&nbsp;&nbsp;&nbsp;bsp;&nbsp;♦ Abrir o arquivo younder-test/WebApp.sln no visual studio 2015&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;♦ Configurar o Web.config da aplicação WebApp.Api &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;configuration>connectionStrings&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;configurar a connectionString para o localhost que o mongodb estiver rodando
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;caso o seu mongodb esteja rodando na porta padrão, não será necessário modificar
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Chave da porta padrão: connectionString="mongodb://localhost:27017/"
&nbsp;&nbsp;♦ Configurar o projeto WebApp.Api para executar na porta localhost:11145
&nbsp;&nbsp;♦ Executar aplicação (F5) 
&nbsp;&nbsp;&nbsp;&nbsp;Ao executar, o nuget deve restaurar os pacotes automáticamente.
  
&nbsp;&nbsp;♦ Abrir younder-test\WebApp.UI no CMD
&nbsp;&nbsp;&nbsp;&nbsp;Caso a api não esteja rodando na porta localhost:11145
&nbsp;&nbsp;&nbsp;&nbsp;Abrir o arquivo younder-test\WebApp.UI\src\services\api.js
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Modificar 'http://localhost:11145' para o localhost que a api está executando
&nbsp;&nbsp;executar os comandos:
&nbsp;&nbsp;&nbsp;&nbsp;> npm install
&nbsp;&nbsp;&nbsp;&nbsp;O comando vai instalar todas as dependências da aplicação web
&nbsp;&nbsp;&nbsp;&nbsp;> npm start
&nbsp;&nbsp;&nbsp;&nbsp;O comando vai iniciar a aplicação Web em http://localhost:3000
&nbsp;&nbsp;Páginas existentes:
&nbsp;&nbsp;http://localhost:3000/cliente/list
&nbsp;&nbsp;http://localhost:3000/cliente/new
&nbsp;&nbsp;http://localhost:3000/cliente/edit
</pre>
      
      
      
