## Login feito com React utilizando DotNetCore2 e Token de segurança JWT

Ao tentar se logar no sistema o React consome a Api que retorna um token de autenticação.

*O sistema utiliza banco de dados [localDB] utilizando o framework Identidy padrão do DotNet, como 
estamos usando o Identidy podemos alterar a base de dados apenas adicionando a string de conexao que o Identidy se encarrega de criar as tabelas*



*Para utilizar é necessário que instale a versão mais recente do react, a versão e suas depencias estão informadas aqui:*
 "dependencies"
    - "react": "^16.8.6",
    - "react-dom": "^16.8.6",
    - "react-scripts": "3.0.1"
  
  
  Na api é necessario o Core2
    - netcoreapp2.2
  
---

## Próximas Melhorias para o Sistema

1. Será adicionado  **Criptografia** no envio e no recebimento das informações.
  - Ao consumir a API as informações podem ser interceptadas, por isso será adiciona um sistema de criptografia de descritografia.
  
2. Será adicionado Sistema de **Log**.
  - Utilizar para salvar histórico de Acessos e/ou Tentativas.

3. Será adicionado Acesso de **2 fatores**. (Opcional para o Usuário)
  - Melhorar o sistema de segurança.
  
4. Será adicionado **Funcionalidades**.
  - Esqueceu a Senha?
  - Requireds
  - Alertas (Customizados)

5. Melhoria no código do React (Clean Code).

---

## Correções e Bugs

1. Necessário corrigir **Cors**

*O Cross-Origin Resource Sharing ou 'compartilhamento de recursos de origem cruzada' cujo acrônimo é **CORS** é um padrão W3C sendo uma especificação de uma tecnologia de navegadores que define meios para um servidor permitir que seus recursos sejam acessados por uma página web de um domínio diferente.*


Before you move on, go ahead and explore the repository. You've already seen the **Source** page, but check out the **Commits**, **Branches**, and **Settings** pages.

---

## Clone a repository

Use these steps to clone from SourceTree, our client for using the repository command-line free. Cloning allows you to work on your files locally. If you don't yet have SourceTree, [download and install first](https://www.sourcetreeapp.com/). If you prefer to clone from the command line, see [Clone a repository](https://confluence.atlassian.com/x/4whODQ).

1. You’ll see the clone button under the **Source** heading. Click that button.
2. Now click **Check out in SourceTree**. You may need to create a SourceTree account or log in.
3. When you see the **Clone New** dialog in SourceTree, update the destination path and name if you’d like to and then click **Clone**.
4. Open the directory you just created to see your repository’s files.

Now that you're more familiar with your Bitbucket repository, go ahead and add a new file locally. You can [push your change back to Bitbucket with SourceTree](https://confluence.atlassian.com/x/iqyBMg), or you can [add, commit,](https://confluence.atlassian.com/x/8QhODQ) and [push from the command line](https://confluence.atlassian.com/x/NQ0zDQ).
