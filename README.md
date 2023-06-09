
# Automação RPA

**Wendrya Andrade Oliveira**

### Aplicação

Este projeto de automação RPA foi desenvolvido em C# utilizando Selenium WebDriver.

Na aplicação é realizada uma busca automatizada no site da AeC (https://www.aec.com.br/) e os resultados são gravados em um banco de dados.

### Passo a Passo

O sistema RPA inicia com a abertura do site da AeC (https://www.aec.com.br/), e logo após adiciona uma palavra no campo de busca e realiza a pesquisa.

Para cada resultado da pesquisa, o projeto salva em uma lista as seguintes informações: 

- Titulo
- Área
- Autor
- Descrição
- Data de Publicação

Ao final da página, é clicado em "Ver mais" e assim, salva-se todos os resultados da pesquisa feita, até que não tenha mais nenhum. Ao final do processo, todos os dados são salvos no banco de dados.

### Como rodar a aplicação

Para rodar a aplicação é necessário instalar os seguintes pacotes NuGet:

- EntityFramework 6.4.4
- Selenium.WebDriver 4.8.2
- Selenium.Support 4.8.2
- Selenium.WebDriver.ChromeDriver

A aplicação utiliza o Entity para gerenciar o banco de dados. É necessário alterar a ConnectionString no arquivo App.config para a conexão de sua máquina local. Após isso, rodar a migration para criar o banco e as tabelas utilizando o comando "update-database".
