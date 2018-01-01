class Solution {
public:
    int strStr(string haystack, string needle) {
        if(needle.empty() )
            return 0;
        if (haystack.empty())
            return -1;
        int len=haystack.length() - needle.length()>0?haystack.length() - needle.length():0;
        for (int i = 0; i <= len; i++)
        {
            if (haystack[i] == needle[0])
            {
                bool isSub = true;
                for (int j = 0; j<needle.length(); j++)
                {
                    if (haystack[i + j] != needle[j])
                        isSub = false;
                }
                if (isSub)
                    return i;
            }          
        }
        return -1;
    }
};