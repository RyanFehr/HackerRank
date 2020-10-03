#include <bits/stdc++.h>

using namespace std;

/*
 * Complete the truckTour function below.
 */
int truckTour(vector<vector<int>> petrolpumps) {
    int tp=0;
   int i=0,start=0;
   int n=petrolpumps.size();
   for(start=0;start<n;start++)
   {
       tp=0;
       i=start;
       int counter=0;
       
       while(tp+petrolpumps[i][0]-petrolpumps[i][1]>=0&&counter<n)
       {
           tp=tp+petrolpumps[i][0]-petrolpumps[i][1];
           counter++;
           i=(i+1)%n;
       }
       if(counter==n)
           return start;
       else
           continue;
   }
   return -1;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    int n;
    cin >> n;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');

    vector<vector<int>> petrolpumps(n);
    for (int petrolpumps_row_itr = 0; petrolpumps_row_itr < n; petrolpumps_row_itr++) {
        petrolpumps[petrolpumps_row_itr].resize(2);

        for (int petrolpumps_column_itr = 0; petrolpumps_column_itr < 2; petrolpumps_column_itr++) {
            cin >> petrolpumps[petrolpumps_row_itr][petrolpumps_column_itr];
        }

        cin.ignore(numeric_limits<streamsize>::max(), '\n');
    }

    int result = truckTour(petrolpumps);

    fout << result << "\n";

    fout.close();

    return 0;
}
