public class Solution {
    string polishEmail(string email)
    {
        var Name = email.Split('@');
        var localName=Name[0];
        var domainName =Name[1];

        var localNameSb = new StringBuilder();
        for (int i = 0; i < localName.Length; i++)
        {
            if (localName[i] == '+')
                break;
            else if (localName[i] == '.')
                continue;
            else
                localNameSb.Append(localName[i]);
        }
        return localNameSb.ToString()+"@"+ domainName;
    }
    public int NumUniqueEmails(string[] emails) {
        var uniqueEmails = new HashSet<string>();
        for(int i = 0; i < emails.Length; i++)
        {
            uniqueEmails.Add(polishEmail(emails[i]));
        }
        return uniqueEmails.Count;
    }
}