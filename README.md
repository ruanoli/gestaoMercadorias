<h2>CASE:</h2>
A xxxx é uma importante empresa de logística do Rio de Janeiro. Com uma vasta carteira de clientes, a empresa decidiu implantar um sistema de Supply Chain para aumentar a qualidade e eficiência nos seus processos. Já existe um controle feito em Excel, porém, este cadastro está sempre obsoleto por não existir um sistema centralizado de controle de entrada e saída de mercadorias.

<h5>A empresa então contratou a xxxx para desenvolver um sistema online onde serão cadastrados os tipos de mercadorias e suas entradas e saídas. O sistema deve possuir as seguintes funcionalidades:</h5>

<ol>
  <li>Gerenciamento de mercadorias;</li>
  <li>Gerenciamento de entrada e saída de mercadorias;</li>
  <li>Tela para visualização das entradas e saídas por mês de cada mercadoria em formato de gráfico;</li>
  <li>Exportar relatório mensal com todas as entradas e saídas de todas as mercadorias no formato PDF;</li>
</ol>

<h5>O sistema deve seguir alguns preceitos básicos da engenharia de software e utilizar o padrão de arquitetura ASP.NET MVC, com os frameworks jQuery e BootsTrap e o banco de dados de sua escolha. Os seguintes pontos devem ser seguidos:</h5>
<ol>
  <li>Os dados entrados devem ser validados no cliente, ou seja, não devem ser enviados dados ao servidor sem já terem sido validados em javascript ou algum componente de validação. Validar implica em não deixar o usuário enviar os dados com campos em branco no formulário, não deixar o usuário digitar caracteres inválidos na submissão da data, etc;</li>
  <li>O sistema deve ser desenvolvido em ASP.NET MVC utilizando a linguagem C# com a versão do .NET 6.0;</li>
  <li>As informações das mercadorias e suas entradas e saídas devem ser armazenadas em um banco de dados SQL Server;</li>
  <li>O bootstrap deve ser utilizado;</li>
  <li>No cadastro de uma nova mercadoria, devem ser salvos o nome, número de registo, o fabricante, o tipo e a descrição da mesma. O objetivo dessa tela simples é persistir no banco de dados a mercadoria cadastrada</li>
  <li>O cadastro da entrada deve conter a quantidade, data e hora, local e um Dropdownlist com todas as mercadorias cadastradas. Na tabela de entrada do banco de dados deverá ser salva a mercadoria selecionada no dropdownlist [select];</li>
  <li>Por último, o cadastro da saída deverá, conter a quantidade, a data e hora, localm e um dropdownlis com todas as mercadorias cadastradas. Na tabela de saída do banco de dados deverá ser salva a mercadoria selecionada no dropdownlist [select];</li>
  <li>O script de criação do banco deverá ser apresentado;</li>
  <li>Qualquer funcionalidade extra será levada em consideração na avaliação do case, como por exemplo: verificação da disponibilidade de mercadorias, relatórios gerenciais, etc.</li>
</ol>

<h5>Softwares necessários:</h5>
<ul>
  <li>Visual Studio Community</li>
</ul>
