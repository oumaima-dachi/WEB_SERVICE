<%-- 
    Document   : index
    Created on : Nov 24, 2020, 10:15:28 AM
    Author     : ahmed
--%>
    <%-- start web service invocation --%><hr/>
<%-- end web service invocation --%><hr/>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
    </head>
    <body>
        <h1>Hello World!</h1>
        <%
        try {
            webservice.CalculatriceWS_Service service = new webservice.CalculatriceWS_Service();
            webservice.CalculatriceWS port = service.getCalculatriceWSPort();
             // TODO initialize WS operation arguments here
            int i = 5;
            int j = 10;
            // TODO process result here
            int result = port.add(i, j);
            out.println("Result = "+result);
        } catch (Exception ex) {
            // TODO handle custom exceptions here
        }
        %>
    </body>
</html>
