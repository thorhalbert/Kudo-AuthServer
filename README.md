# VRWorlds - Kudo Server Authentication/Authorization Service

Based on [IdentityServer4](https://github.com/IdentityServer/IdentityServer4)



The basic security premise with VRWorlds is that you trust your Kudo Server, and that, at the beginning of things, you log into your Avatar's Kudo Server.  Servers inherently trust each other, with the basic requirement being that they prove they own their public certificates by encrypting something from the caller.   



I am not really that sure about IdentityServer4 yet.  It seems comprehensive.  My one that is that users, like authenticating against oauth2 services at facebook and google can also authenticate with oauth2 against their own kudo server (though likely we'll allow other federated logins to facebook and google and servers like it -- github maybe).   I'm not exactly sure that there is a need to authenticate other servers for other worlds, just to certify they're who they say they are.



You have to present a kudo-certificate (held on the Kudo server on your Avatar server) which is in the form of a Deed, or a Visa to visit a world.  It may be that further authentication is uneeded.  However, we still need Authorization (which is a list of things you're permitted to do), so there may need to be a login proxy to store this on.


