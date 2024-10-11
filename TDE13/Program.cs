Empresa empresa = new Empresa();
Funcionario funci = new Funcionario("Lucas", 18);
Gerente gerente = new Gerente("Adalbertinho", 55, 300);
Estagiario estagi = new Estagiario("Jonas", 16);

empresa.AdicionarFuncionarios(funci);
empresa.AdicionarFuncionarios(gerente);
empresa.AdicionarFuncionarios(estagi);

empresa.ListarFuncionario();