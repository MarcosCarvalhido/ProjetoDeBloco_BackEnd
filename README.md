![Logo Infnet](https://curso.infnet.com.br/c/wp-content/uploads/sites/59/2022/12/Infnet-Logo.png)

# **PROJETO DE BLOCO**

## **Projeto de Bloco: Desenvolvimento Back-end [23E4_5]**

## **Bloco: Desenvolvimento Back-end [23E4 - 24E1]**

### [GRPADS01C2-N1-P2] - Classe 2 - Noite

Por Marcos Carvalhido Rodrigues

*marcos.carvalhido@al.infnet.edu.br*

Professor: Luiz Paulo Bomeny Maia

---

Link para o Projeto no Moodle: https://lms.infnet.edu.br/moodle/mod/assign/view.php?id=376795

1. Realizar o levantamento de requisitos funcionais, utilizando para cada requisito a sigla RF-xx, onde xx é o número do requisito.
    1. As funcionalidades do sistema são:
    - RF-01 - Gerenciar turmas
    - RF-02 - Gerenciar disciplinas
    - RF-03 - Criar disciplinas
    - RF-04 - Alterar disciplinas
    - RF-05 - Consultar disciplinas
    - RF-06 - Excluir disciplinas
    - RF-07 - Gerenciar informações dos alunos
    - RF-08 - Emitir histórico escolar
    - RF-09 - Solicitar histórico
    - RF-10 - Consultar disciplinas
    - RF-11 - Consultar histórico
    - RF-12 - Consultar grade
    - RF-13 - Consultar frequências
    - RF-14 - Consultar Avaliações
    - RF-15 - Gerenciar disciplinas inscritas
    - RF-16 - Inscrever disciplinas
    - RF-17 - Cancelar disciplinas
    - RF-18 - Lançar notas
    - RF-19 - Lançar frequências
    - RF-20 - Gerenciar informações dos professores
    - RF-21 - Afastar temporariamente
2. Realizar o levantamento de requisitos não funcionais, utilizando para cada requisito a sigla RNF-xx, onde xx é o número do requisito.
    1. As qualidades  não funcionais do sistema são:
    - RNF-01: Garantir confidencialidade dos dados dos alunos e professores.
    - RNF-02: Ter desempenho de disponibilidade em momentos de pico de uso.
    - RNF-03: Garantir acesso a alunos e professores com necessidades especiais.
3. Descrever os atores do sistema.
    1. Atores presentes no sistema:
    - Departamento de Registro Acadêmico, responsável por gerenciar as disciplinas e informações dos alunos.
    - Departamento de Recursos Humanos, responsável por gerenciar as informações dos professores.
    - Coordenação acadêmica, responsável pelo gerenciamento das turmas.
    - Professores, responsável por lançar avaliações e frequências.
    - Alunos, que fazem consultas ao sistema e se inscrevem em disciplinas.
4. Implementar o Diagrama de Casos de Uso.
    1. Link para o diagrama de caso de uso:  https://drive.google.com/file/d/1Sn608lzmWIqqI5Nj1wActiXjuuHeW745/view?usp=sharing
        
   
        
5. Descrever o caso de uso associado ao lançamento de frequências.
    1. O caso de uso do lançamento de frequência pode ser destrinchado da seguinte forma:
    - **Lançar Frequências** - CSU02
        - *Descrição:*
            - Permite o lançamento das frequências dos alunos no sistema.
        - *Atores:*
            - Professor.
        - *Precondições:*
            - As Informações dos alunos devem estar no sistema.
            - As informações da turma devem estar no sistema.
        - *Fluxo principal:*
            - Departamento de Registro Acadêmico registra o aluno [RF-07]
            - Departamento de Registro Acadêmico registra a turma. [RF-03]
            - Coordenação acadêmica define período, os  horários, local e o professor da turma. [RF-01]
            - Coordenação acadêmica verifica a quantidade mínima e máxima de presença para a turma.
            - O aluno checa os pré-requisitos de credito para entrar na turma.
            - Aluno se inscreve na turma [RF-16]
            - Aluno frequenta a aula ou não.
            - professor lança a frequência no sistema. [RF-19]
        - *Pós-condições*
            - O aluno precisa ter pelo menos 75% de presença para ser aprovado.
            - A frequência é armazenada no histórico escolar do aluno.
6. Identificar as classes do sistema, utilizando o diagrama de classes.
7. Identificar os atributos das classes do sistema, utilizando o diagrama de classes.
8. Identificar as relações entre as classes do sistema, utilizando o diagrama de classes.
9. Implementar o Diagrama de Classes, considerando todas implementações realizadas no decorrer do projeto.
    1. A seguinte consta a implementação do diagrama de classes contendo todas as classes, atributos e relações do sistema: https://drive.google.com/file/d/1ykpEbOiOmqZOHg7HDtAsLCIzPxJX0hiB/view?usp=sharing
        
    
        
10. Descrever o caso de uso Lançar Notas considerando apenas o fluxo principal
    1. O caso de uso de Lançar Notas pode ser destrinchado da seguinte forma:
    - **Lançar notas** - CSU01
        - *Descrição:*
            - Permite o lançamento das notas dos alunos no sistema.
        - *Atores:*
            - Professor.
        - *Precondições:*
            - As notas do aluno devem estar no sistema.
            - as informações do aluno devem estar no sistema.
            - As informações da turma devem estar no sistema.
        - *Fluxo principal:*
            - Departamento de Registro Acadêmico registra o aluno [RF-07]
            - Departamento de Registro Acadêmico registra a turma. [RF-03]
            - Coordenação acadêmica define período, os  horários, local e o professor da turma. [RF-01]
            - Coordenação acadêmica verifica a quantidade mínima e máxima de presença para a turma.
            - O aluno checa os pré-requisitos de credito para entrar na turma.
            - Aluno se inscreve na turma [RF-16]
            - Aluno é aprovado ou não.
            - professor lança as notas no sistema. [RF-18]
        - *Pós-condições*
            - O aluno precisa ter uma media maior do que 5 para ser aprovado
            - As notas são armazenadas no histórico escolar do aluno.
11. Implementar o diagrama de sequência que reflita o caso de uso *Lançar Notas*, utilizando apenas as classes envolvidas. Não se preocupe com os fluxos condicionais e de repetições
    1. Link para o diagrama de sequencia: https://drive.google.com/file/d/1uPGx4ZdKvfnYIJdcsaSdUAxG3FgW1UHq/view?usp=sharing 
        
    
        
12. Implementar as classes *Aluno, Professor, Disciplina* e *Turma* a partir do Diagrama de Classes (DC) abaixo, que não representa exatamente o minimundo do SCA, apresentado inicialmente. O DC omitiu os construtores, os métodos get, set e toString das classes.
   
    
    !https://lms.infnet.edu.br/moodle/pluginfile.php/1072180/mod_assign/intro/IMG12.png
    
13. Testar as classes criadas a partir do programa principal, utilizando a console, e verifique o funcionamento correto dos métodos da classe Turma.
    1. executando os seguintes passos:
        1. Crie uma turma com um professor e uma disciplina;
        2. Adicione dois alunos na turma criada anteriormente e verifique se é possível abrir a turma;
        3. Adicione mais oito alunos e depois tente adicionar mais aluno e verifique se é possível;
        4. Depois gere a pauta conforme descrito na questão anterior.
  
14. Implemente as classes *Aluno, Curso, Grade* e *Disciplina* a partir do Diagrama de Classes (DC) abaixo, que não representa exatamente o minimundo do SCA, apresentado inicialmente. O DC omitiu os construtores, os métodos get, set e toString das classes.
    

    
15. Seria possível reutilizar a modelagem do SCA, pensando especificamente no caso do sistema acadêmico do Infnet? Quais as mudanças seriam necessárias na especificação do sistema?
    1. Para Criar um sistema acadêmico especifico para a metodologia do Infnet seria necessário uma quantidade considerável de modificações:
        1. Substituição das classes de GradeCurricular e Disciplina por uma de Bloco.
        2. Substituir a classe de turma por uma classe de disciplina com materiais regulares e projeto de bloco.
        3. Remover a classe de PreRequisitos e os atributos de Créditos e Carga Horaria
        4. os Atributos Na classe de avaliação precisariam ser trocadas para TPs e Ats.
    2. Link para o diagrama: https://drive.google.com/file/d/1gOqvGZZ7ffnAB4MCso8PgEqwNgv-1Vrc/view?usp=sharing

    
16. Seria possível implementar o SCA utilizando uma arquitetura Model-View-Controller (MVC)? Dê um exemplo de CRUD (Create, Read, Update e Delete) que poderia ser aplicado em uma das classes do DC utilizando o MVC.
    1. Ultilizando a arquitetura MVC, a classe turma seria o Model, onde as informações da turma estariam armazenadas. a classe TurmaController seria a responsável por executar os métodos do crud, e o view seria a tela de interação com o usuário aluno ou professor. 
17. Implemente as classes *Aluno, Professor, Disciplina* e *Turma* a partir do Diagrama de Classes (DC) abaixo, que não representa exatamente o minimundo do SCA, apresentado inicialmente. Agora, o DC permite que um aluno, professor e disciplina possam ser alocados em mais de uma turma. O DC omitiu os construtores e os métodos get, set e toString das classes.
    1.
    
