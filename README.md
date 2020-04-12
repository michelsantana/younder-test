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

Ao clonar o repositório.
&nbsp;&nbsp;♦ Abrir o arquivo younder-test/WebApp.sln no visual studio 2015 <br />
&nbsp;&nbsp;♦ Configurar o Web.config da aplicação WebApp.Api <br />
&nbsp;&nbsp;&nbsp;&nbsp;configuration>connectionStrings<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;configurar a connectionString para o localhost que o mongodb estiver rodando<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;caso o seu mongodb esteja rodando na porta padrão, não será necessário modificar<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Chave da porta padrão: connectionString="mongodb://localhost:27017/"<br />
&nbsp;&nbsp;♦ Configurar o projeto WebApp.Api para executar na porta localhost:11145<br />
&nbsp;&nbsp;♦ Executar aplicação (F5) <br />
&nbsp;&nbsp;&nbsp;&nbsp;Ao executar, o nuget deve restaurar os pacotes automáticamente.<br />
<br />
&nbsp;&nbsp;♦ Abrir younder-test\WebApp.UI no CMD<br />
&nbsp;&nbsp;&nbsp;&nbsp;Caso a api não esteja rodando na porta localhost:11145<br />
&nbsp;&nbsp;&nbsp;&nbsp;Abrir o arquivo younder-test\WebApp.UI\src\services\api.js<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Modificar 'http://localhost:11145' para o localhost que a api está executando<br />
&nbsp;&nbsp;executar os comandos:<br />
&nbsp;&nbsp;&nbsp;&nbsp;> npm install<br />
&nbsp;&nbsp;&nbsp;&nbsp;O comando vai instalar todas as dependências da aplicação web<br />
&nbsp;&nbsp;&nbsp;&nbsp;> npm start<br />
&nbsp;&nbsp;&nbsp;&nbsp;O comando vai iniciar a aplicação Web em http://localhost:3000<br />
&nbsp;&nbsp;Páginas existentes:<br />
&nbsp;&nbsp;http://localhost:3000/cliente/list<br />
&nbsp;&nbsp;http://localhost:3000/cliente/new<br />
&nbsp;&nbsp;http://localhost:3000/cliente/edit<br />
</pre>
      
      
      
