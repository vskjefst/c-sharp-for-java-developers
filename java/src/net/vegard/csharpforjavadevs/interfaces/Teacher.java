package net.vegard.csharpforjavadevs.interfaces;

public class Teacher implements Reportable {
    @Override
    public void generateReport() {
        System.out.println("I'm a teacher report.");
    }
}
