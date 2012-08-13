<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Detalle de Pagos de cada Alumno</title>
</head>
<body>
<h1>Detalle Pagos Alumno</h1>

<table style="border: 1px solid; width: 500px; text-align:center">
	<thead style="background:#fcf">
		<tr>
			<th>Nombres</th>
			<th>Apellidos</th>
			<th>Monto</th>
			<th>Periodo</th>
			<th>Estado</th>
			<th colspan="4"></th>
		</tr>
	</thead>
	<tbody>
	<c:forEach items="${alumno}" var="alumno">			
		<tr>
			<td><c:out value="${alumno.nombres}" /></td>
			<td><c:out value="${alumno.apellidos}" /></td>
			<td><c:out value="${alumno.monto}" /></td>
			<td><c:out value="${alumno.periodo}" /></td>
			<td><c:out value="${alumno.estado}" /></td>			
		</tr>
	</c:forEach>
	</tbody>
</table>

</body>
</html>