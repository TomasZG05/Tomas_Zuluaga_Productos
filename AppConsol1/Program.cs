Console.WriteLine("Hello, World!");

Clientes cliente = new Clientes();
Inventarios inventario = new Inventarios();
Productos producto = new Productos();
Cajeros cajero = new Cajeros();

public class Inventarios {
    public int id;
    public String? Nombre_producto;
    public Decimal Precio;
    public Boolean Existencia;
    public DateTime Fecha_inventario;
    public List<Productos>? productos;
}

public class Clientes {
    public int id;
    public String? Nombre;
    public Decimal  Estatura;
    public Boolean Vive;
    public DateTime Fecha_ingreso;
    public List<Productos>? productos;
}

public class Productos {
    public int id;
    public String? Seccion;
    public Decimal Peso;
    public Boolean Existencia_tienda;
    public DateTime Fecha_vencimiento;

}

public class Cajeros {
    public int id;
    public String? Nombre;
    public Decimal Estatura;
    public Boolean Ingreso_tienda;
    public DateTime Fecha_ingreso;
    public List<Productos>? productos;
}