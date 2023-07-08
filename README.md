# Binance-Tranding
 
Este projeto tem como objetivo fornecer um código funcional e eficiente, juntamente com conceitos para o design de formulários para uma aplicação visual que opera em uma ou várias contas da corretora Binance, utilizando os repositórios **[https://github.com/SteveWinward/GoogleSheetsWrapper/tree/main](https://github.com/SteveWinward/GoogleSheetsWrapper)** e **https://github.com/binance/binance-connector-dotnet/tree/master/Src**.

Este projeto armazena seus dados no SQLite Cipher e no SQL Server e criptografa a Api Key, Secret Key e o ID da folha ao persisti-los, sendo o uso do SQL Server opcional.

Para usar a Classe GoogleSheets, é preciso adicionar uma conta de serviço do Google. Para saber como criar uma, vá em **https://robocorp.com/docs/development-guide/google-sheets/interacting-with-google-sheets#create-a-google-service-account**.

Para cadastrar uma nova conta, é necessário ter uma API key e uma Secret Key. Também é possível cadastrar uma planilha do Google, fornecendo o nome da guia e o ID da folha.

Para adicionar o ID da planilha, basta copiar e colar essa sequência na URL da planilha:

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/6e5dcf7e-fa66-41a1-a243-ab03d58e69da/Untitled.png)

Após o cadastro, é possível editar o nome, a API key, a Secret key, o nome da guia e o ID da folha.

Para realizar uma nova operação, é necessário fornecer o tipo de operação a ser executada, o lado da operação e o par de negociação. Dependendo do tipo de operação, será necessário definir os valores de preço e stop.

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/b284d1a0-4001-4e16-adee-e024ef1f2b0f/Untitled.png)

É possível escolher operar com uma quantidade definida ou utilizando a porcentagem do saldo da conta. Por exemplo, se uma porcentagem de 6% for definida, a quantidade operada será 6% da quantidade da moeda na conta.

Também é possível escolher operar em todas as contas cadastradas ou apenas em contas selecionadas. Se uma conta não puder realizar a operação, ela será adicionada à lista de pendências.

Todas as operações realizadas pelo software são salvas no banco de dados SQL Server, associadas ao proprietário da conta. Também é possível enviar os dados de uma ou todas as operações realizadas por uma conta para uma planilha do Google. É possível adicionar todos os itens da lista ou apenas os itens selecionados.

Para enviar dados para uma Planilha, é preciso que a planilha esteja com o acesso de "Editor" livre.

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/b60445c3-be76-4897-94bc-577bd73c66d8/Untitled.png)
