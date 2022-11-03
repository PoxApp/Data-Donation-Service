# DataDonation

The Data Donation Service and accompanying tooling for the [QuestionnaireApp](https://github.com/OSPRS/QuestionnaireApp). 

For information how to install and use the software have a look at subdirectories for [api](api/README.md) and [decrypt-tool](decrypt-tool/README.md).  


## Development

Make sure to run `docker-compose up` before continuing with any other README. 

## How to use? 

To use the encryption feature you will have to supply a public key to the [QuestionnaireApp](https://github.com/OSPRS/QuestionnaireApp) and keep the private key secure on your machine. 

The UseCase would be as following: 

1. Generate a key pair in a secure environment, e.g.: `openssl genrsa -des3 -out private.pem 2048`
2. Export the Public and Private Key for use with the `decrypt-tool`: 

```bash
# Export Public Key
openssl rsa -in private.pem -outform PEM -pubout -out public_key.pem
# Export Private Key 
openssl pkcs8 -topk8 -inform PEM -outform PEM -nocrypt -in private.pem -out private_key.pem
# Place them in the 'keys' Folder next to the 'decrypt-tool'
# Run the decrypt-tool
decrypt-tool 
✔ Supply Connection String: server=localhost;database=datadonation;user=root;password=example;OldGuids=true
Checking Connection... Successful.
✔ Supply Private Key Path: keys
Error on entry '4965680f-bf48-4e54-97a3-4a686fc8ccce': Data could not be encrypted. (Data might already be in cleartext: Missing 'encyptedKey' Property etc.)
Export with 1 Entries created. See 'cleartext_data.csv'
# 
```