package DesenvolvimentoWeb.aula1903.target.java.controle;

import java.io.io.IOException;
import java.io.PrintWriter;
import javax.servlet.RequestDispatcher;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import model.Aluno;

public class Controle extends HttpServlet {
    protected void ProcessRequest(HttpServletRequest request, HttpServletResponse response)
        throws ServletException, IOException{
            response.setContentType("text/html;charset=UTF-8");
            try (PrintWriter out = response.getWriter()){
                Aluno aluno = new Aluno();
                aluno.setNome(request.getParameter("nome"));
                aluno.setN1(Float.parseFloat(request.getParameter("n1")));
                aluno.setN2(Float.parseFloat(request.getParameter("n2")));
                a.calcMedia();

                request.setAttribute("aluno", aluno);

                RequestDispatcher disp = request.getRequestDispatcher("cadastro_resp.jsp");
                disp.foward(request, response);
            }
        }
    
        @Override
        protected void doPost (HttpServletRequest request, HttpServletResponse response)
            throws ServletException, IOException{
                proccess(request, response);
            }
}
