<%@page import="model.Aluno"%> <% Aluno aluno = new Aluno(); aluno = (Aluno)
request.getAttribute("aluno"); %> <%@page contentType="text/html" page="UTF-8"%>

<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Reposta Cadastro</title>
  </head>
  <body>
    <h1>Resposta Cadastro - Servlet</h1>
    <pre>
        Nome:       <%=aluno.getNome() %>
        Nota 1:     <%=aluno.getN1() %>
        Nota 2:     <%=aluno.getN2() %>
        Media:      <%=aluno.getMedia() %>
        Situação:   <%=aluno.getSituação() %>  
    </pre>
  </body>
</html>
