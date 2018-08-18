#include <bits/stdc++.h>

using namespace std;

vector<string> split_string(string);

// Complete the nonDivisibleSubset function below.
int nonDivisibleSubset(int k, vector<int> S) {
    int ans=0;
    int arr[k/2][2],x[2];
    x[0]=0;
    x[1]=0;
    for(int i=0;i<k/2;i++)
    {
        arr[i][0]=0;
        arr[i][1]=0;
    }
    for(int i=0;i<S.size();i++)
    {
        int c;
        c=S[i]%k;
        if(c>(k/2) && k%2==0)
            arr[k-c-1][1]++;
        else if(c>(k/2) && k%2==1)
            arr[k-c-1][1]++;
        else if (c<(k/2) && k%2==0)
            arr[c-1][0]++;
        else if (c<=(k/2) && k%2==1)
            arr[c-1][0]++;
        if(c==0)
            x[0]=1;
        else if(k%2==0 && c==k/2)
            x[1]=1;
    }
    ans=x[0]+x[1];
    for(int i=0;i<k/2;i++)
    {cout<<arr[i][0]<<arr[i][1]<<endl;
        if(arr[i][0]>arr[i][1])
            ans=arr[i][0]+ans;
        else
            ans=ans+arr[i][1];
    }
    return ans;
}

int main()
{
    ofstream fout(getenv("OUTPUT_PATH"));

    string nk_temp;
    getline(cin, nk_temp);

    vector<string> nk = split_string(nk_temp);

    int n = stoi(nk[0]);

    int k = stoi(nk[1]);

    string S_temp_temp;
    getline(cin, S_temp_temp);

    vector<string> S_temp = split_string(S_temp_temp);

    vector<int> S(n);

    for (int i = 0; i < n; i++) {
        int S_item = stoi(S_temp[i]);

        S[i] = S_item;
    }

    int result = nonDivisibleSubset(k, S);

    fout << result << "\n";

    fout.close();

    return 0;
}

vector<string> split_string(string input_string) {
    string::iterator new_end = unique(input_string.begin(), input_string.end(), [] (const char &x, const char &y) {
        return x == y and x == ' ';
    });

    input_string.erase(new_end, input_string.end());

    while (input_string[input_string.length() - 1] == ' ') {
        input_string.pop_back();
    }

    vector<string> splits;
    char delimiter = ' ';

    size_t i = 0;
    size_t pos = input_string.find(delimiter);

    while (pos != string::npos) {
        splits.push_back(input_string.substr(i, pos - i));

        i = pos + 1;
        pos = input_string.find(delimiter, i);
    }

    splits.push_back(input_string.substr(i, min(pos, input_string.length()) - i + 1));

    return splits;
}

