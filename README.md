##Login feito com React utilizando DotNetCore2 e Token de segurança JWT

Ao tentar se logar no sistema o React consome a Api que retorna um token de autenticação.

*O sistema utiliza banco de dados [localDB] utilizando o framework Identidy padrão do DotNet, como 
estamos usando o Identidy podemos alterar a base de dados apenas adicionando a string de conexao que o Identidy se encarrega de criar as tabelas*



*Para utilizar é necessário que instale a versão mais recente do react, a versão e suas depencias estão informadas aqui:*
 "dependencies"
    -"react": "^16.8.6",
    -"react-dom": "^16.8.6",
    -"react-scripts": "3.0.1"
  
  
   Na api é necessario o Core2
     -netcoreapp2.2
  

---

## Próximas Melhorias para o Sistema

1. Adicionar **Criptografia** no envio e no recebimento das informações.
  - Ao consumir a API as informações podem ser interceptadas, por isso será adiciona um sistema de criptografia de descritografia.
  
2. Adicionar Sistema de **Log**.
  - Utilizar para salvar histórico de Acessos e/ou Tentativas.
  
3. Click the **Edit** button.
4. Delete the following text: *Delete this line to make a change to the README from Bitbucket.*
5. After making your change, click **Commit** and then **Commit** again in the dialog. The commit page will open and you’ll see the change you just made.
6. Go back to the **Source** page.

---

## Create a file

Next, you’ll add a new file to this repository.

1. Click the **New file** button at the top of the **Source** page.
2. Give the file a filename of **contributors.txt**.
3. Enter your name in the empty file space.
4. Click **Commit** and then **Commit** again in the dialog.
5. Go back to the **Source** page.

Before you move on, go ahead and explore the repository. You've already seen the **Source** page, but check out the **Commits**, **Branches**, and **Settings** pages.

---

## Clone a repository

Use these steps to clone from SourceTree, our client for using the repository command-line free. Cloning allows you to work on your files locally. If you don't yet have SourceTree, [download and install first](https://www.sourcetreeapp.com/). If you prefer to clone from the command line, see [Clone a repository](https://confluence.atlassian.com/x/4whODQ).

1. You’ll see the clone button under the **Source** heading. Click that button.
2. Now click **Check out in SourceTree**. You may need to create a SourceTree account or log in.
3. When you see the **Clone New** dialog in SourceTree, update the destination path and name if you’d like to and then click **Clone**.
4. Open the directory you just created to see your repository’s files.

Now that you're more familiar with your Bitbucket repository, go ahead and add a new file locally. You can [push your change back to Bitbucket with SourceTree](https://confluence.atlassian.com/x/iqyBMg), or you can [add, commit,](https://confluence.atlassian.com/x/8QhODQ) and [push from the command line](https://confluence.atlassian.com/x/NQ0zDQ).
