public class Singleton {

    private static Singleton singleton;
    private string value;

    private Singleton() {
      
    }

    public static Singleton getInstance() {
        if(singleton == null)
        {
            singleton = new Singleton();
        }

        return singleton;
    }

    public string getValue() {
        return singleton.value;
    }

    public void setValue(string value){
        singleton.value = value;
    }
}
