# Ignite2019
Ignite 2019 Session downloader

Visit :
https://api-myignite.techcommunity.microsoft.com/api/session/all

Identify the SessionCode you want.

To download one session:

./Download-Resources.ps1 Ignite2019 pre21

pre21 is the sessionCode

To download all sessions from Ignite 2019:

./Download-Resources.ps1 -directory Ignite2019 -excludeProducts ""

To download all sessions from Ignite 2019 with the default exclusions (Dynamics 365,Microsoft 365,Power Platform):

./Download-Resources.ps1 -directory Ignite2019

Note: This exclusion products is a comma separated list and can be added to or removed from in the powershell script.
