## Login feito com React utilizando DotNetCore2 e Token de segurança JWT

![alt text](https://camo.githubusercontent.com/dd73205c443cd1f009ed0d81b7d748d01a917f31/68747470733a2f2f696d672e736869656c64732e696f2f6e706d2f762f72656163742d69636f6e732e7376673f7374796c653d666c61742d737175617265)


#### Descrição 
Ao tentar se logar no sistema o React consome a Api que retorna um token de autenticação.

*O sistema utiliza banco de dados [localDB] utilizando o framework Identidy padrão do DotNet.* 

##### Como estamos usando o Identidy podemos alterar a base de dados apenas adicionando a string de conexao que o Identidy se encarrega de criar as tabelas

Este modelo segue uma estrutura Bootstrap-React de estilo mobile.

*Para utilizar é necessário que instale a versão mais recente do react, a versão e suas dependências estão informadas aqui:*
 
 "dependencies"
 
    - "react": "^16.8.6",
    - "react-dom": "^16.8.6",
    - "react-scripts": "3.0.1"
  
  
  Na api é necessario o Core2
  
    - netcoreapp2.2
  
---



### Foi Melhorado

1. :heavy_check_mark: Será adicionado  **Criptografia** no envio e no recebimento das informações.
  - Ao consumir a API as informações podem ser interceptadas, por isso será adiciona um sistema de **[ criptografia & descriptografia ]**.
  
  
  
  ## Próximas Melhorias para o Sistema
  
  
2. Será adicionado Sistema de **Log**.
  - Utilizar para salvar histórico de Acessos e/ou Tentativas.


3. Será adicionado Acesso de **2 fatores**. (Opcional para o Usuário).
  - Melhorar o sistema de segurança.


4. Será adicionado **Funcionalidades**.
  - Esqueceu a Senha?
  - Sou novo aqui.
  - Requireds.
  - Alertas (Customizados).


5. Melhoria no código do React (Clean Code).

---


## Correções e Bugs

1. Necessário corrigir **Cors**

*O Cross-Origin Resource Sharing ou 'compartilhamento de recursos de origem cruzada' cujo acrônimo é **CORS** é um padrão W3C sendo uma especificação de uma tecnologia de navegadores que define meios para um servidor permitir que seus recursos sejam acessados por uma página web de um domínio diferente.*


---

## Como Usar e Configurações Iniciais

 Caso precise alterar a url e a porta
 
    - api\Properties\launchSettings.json*


 Para alterar a senha Inicial

    - api\Models\IdentityInitializer.cs*
   
 
 #### :mega: Obs: É fundamental que essas informações nunca fiquem no código **(estão apenas para estudo)**
                
