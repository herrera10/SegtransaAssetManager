USE [Segtransa]
GO
/****** Object:  StoredProcedure [dbo].[spUsuariosRetornaDatosId]    Script Date: 4/19/2019 2:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






-- =============================================
-- Description:	<Usuarios - Retorna Rol de Usuario>
-- =============================================

Create or ALTER PROCEDURE sp_RetornaRolUsuario
@IdUsuario int,
@contrasena varchar(max)
AS
BEGIN
select RolUsuario from Usuarios 
where IdUsuario = @IdUsuario
and Contrasena = @contrasena
END

exec sp_RetornaRolUsuario 3,12345