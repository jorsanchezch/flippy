#flippy back-end
Designed a .NET Core API with a DD Design.

To create migrations successfully, use:
<code>dotnet ef migrations add <Name> -p Domain -s Infrastructure</code>
To apply them with <code>dotnet ef update database -p Domain -s Infrastructure</code>, remove the migrations assembly reference to the Domain Project on the DbContext.

Currently the Add Migration is creating names inconsistently.
