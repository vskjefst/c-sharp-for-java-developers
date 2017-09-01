package net.vegard.csharpforjavadevs.interfaces;

public class Student implements Reportable {
    @Override
    public void generateReport() {
        System.out.println("I'm a student report.");
    }
}
