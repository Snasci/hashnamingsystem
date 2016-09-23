# Hash Naming System

This prototype software is an algorithmic replacement for DNS.  Rather than an expensive global DNS infrastructure, this software take an MD5 hash of a term and converts it to an IPv6 or IPv4 address.

For example:

Google maps to c822:c1b6:3853:ed27:3b89:687a:c505:f9fa and 197.5.249.250

Microsoft maps to 5f53:2a3f:c4f1:ea40:3f37:70f:59a7:a53a and 89.167.165.58



How Is This Used In Practice

For businesses, the trading name of a company and its associated IPv6 hash-based address need to be protected in law as an extension of current trade mark legislation.  Then it is simply a matter of making the IPv6 address routable.  Most likely done by a competent authority such as an internet provider or the company itself.

In a broader implementation, registration and ownership can be performed by the internet service provider and recorded in the bitcoin blockchain.  This allows addresses to be traded and provides a strong level of protection.

It is possible for URLs to remain the way the are mycompany.com.  Or simply use a brand name for your main website such as Microsoft or Google.  URLs can take the form Microsoft/home.aspx or Google/analytics.



Symantic Web

Interestingly, this also provides a method of providing intrinsic search and reducing search traffic.  Search terms can be mapped to IPv6 addresses.  For example:

'House Prices In Western Europe' maps to 6ba9:698d:a6b1:710c:e29a:814d:323c:b310 and 50.60.179.16

If I were to send the IPv6 address to Google it would give me back results for that term, thus reducing the size of the traffic.

Further, if websites analyze words on their own sites, we can build a symantic picture of the web at the routing level.  This is simply creating an entry for the IPv6 address of the term and mapping all the sites that carry that term to this entry.  This is complex and carries security considerations, however, it does provide a routable semantic view of the web.

What this does not provide is relevancy.  This is a ranking procedure and typically provided by search companies such as Google, Bing, Yahoo, Baidu and Yandex amongst others.  Semantic routing merely provides a natural language method of discovering web content and a quick way to perform cross-referencing of terms.

As such, this provides a much needed search system on the web, without competing against major search engines.



Notes On IPv4

The address space in IPv4 is much smaller and collisions would increase.  As such, probably best for internal networks.

Notes On Loopback Addresses and Non-Routable Addresses

If certain terms produce IP addresses in this region, then a secondary form of generating the address for the term must be used.  Another approach is just to use the term 'LOOPBACK:LOCAL' for loopback addresses.



Separating Search and Machine names

One potential solution is to define a prefix such as 'MachineName:GOOGLE-US-3456789'



Reverse Lookups

Using an MD5, going from an IP address to a name is currently not possible.  It is possible to store this information in any blockchain and have it publicly available.
