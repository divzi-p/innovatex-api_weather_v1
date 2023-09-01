param location string
param aksControlPlaneIdentityName string
//param aksClusterAdminGroupName string

// BYO Control Plane Identity
resource controlPlaneIdentity 'Microsoft.ManagedIdentity/userAssignedIdentities@2018-11-30' = {
  name: aksControlPlaneIdentityName
  location: location
}



output controlPlaneIdentityPrincipal string = controlPlaneIdentity.properties.principalId
//output aksClusterAdminGroupId string = clusterAdminGroupLookup.properties.outputs['Result']['id']
