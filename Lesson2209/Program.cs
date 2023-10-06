
Student tommy = new Student("Tommy", 2, new int[]{3,4,5,4,4});
Student jim = new Student("Jim", 1, new int[] { 5, 5, 5, 4, 4 });
Student bella = new Student("Bella", 2, new int[] { 2, 3, 4, 5, 4 });
Student mike = new Student("Mike", 1, new int[] { 4, 5, 3, 3, 4 });
Student ronnie = new Student("Ronnie", 2, new int[] { 4, 4, 5, 5, 5 });

Student[] students = new Student[5];
students[0] = tommy;
students[1] = jim; 
students[2] = bella;
students[3] = mike;
students[4] = ronnie;

public record Student(string Name, int Group, int[] Marks);


