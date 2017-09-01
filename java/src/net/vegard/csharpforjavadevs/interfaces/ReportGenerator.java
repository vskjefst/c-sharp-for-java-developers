package net.vegard.csharpforjavadevs.interfaces;

import static java.util.Arrays.asList;

public class ReportGenerator {
    public static void main(final String[] args) {
        asList(new Student(), new Teacher()).forEach(Reportable::generateReport);
    }
}
