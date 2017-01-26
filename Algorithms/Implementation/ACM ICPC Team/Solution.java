//Problem: https://www.hackerrank.com/challenges/acm-icpc-team
//Java 8
import java.io.*;
import java.util.*;
import java.lang.Math;

public class Solution {

    public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
        Scanner input = new Scanner(System.in);
        int n = input.nextInt();
        int m = input.nextInt();
        
        String[] skills = new String[n];
        int maxSkills = 0;
        int maxSkillTeams = 0;
        input.nextLine(); //advances the past the first line of input integers
        
        for(int i = 0; i < n; i++)
        {
            skills[i] = input.nextLine();
        }
        
        
        for(int i = 0; i < n; i++)
        {
            for(int j = i+1; j < n; j++)
            {
                String member1 = skills[i];
                String member2 = skills[j];
                int skillSet = 0;
                
                for(int k = 0; k < m; k++)
                {
                    if(member1.charAt(k) == '1' || member2.charAt(k) == '1')
                    {
                        skillSet++;
                    }
                }

                maxSkillTeams += (maxSkills == skillSet) ? 1 : 0;
                
                if(skillSet > maxSkills)
                {
                    maxSkillTeams = 1;
                    maxSkills = skillSet;
                }
            }
        }
        System.out.println(maxSkills + "\n" + maxSkillTeams);
    }
}