# AspNetIdentity-SSO

This POC shows how to authenticate users using a different application.

When having multiple applications and want to share the security between them, this might be handy. 

uses `AspNet Identity` and `Owin`

For real SSO, deployed on separate machine, I imagine `machinKey` should be set the same in the `web.config` of all applications including Authenticator itself. 

Haven't tested on https.
