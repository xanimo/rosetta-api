/*
 * Rosetta
 *
 * Build Once. Integrate Your Blockchain Everywhere.
 *
 * API version: 1.4.10
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

// The Version object is utilized to inform the client of the versions of different components of the Rosetta implementation.
type Version struct {
	// The rosetta_version is the version of the Rosetta interface the implementation adheres to. This can be useful for clients looking to reliably parse responses.
	RosettaVersion string `json:"rosetta_version"`
	// The node_version is the canonical version of the node runtime. This can help clients manage deployments.
	NodeVersion string `json:"node_version"`
	// When a middleware server is used to adhere to the Rosetta interface, it should return its version here. This can help clients manage deployments.
	MiddlewareVersion string `json:"middleware_version,omitempty"`
	// Any other information that may be useful about versioning of dependent services should be returned here.
	Metadata *interface{} `json:"metadata,omitempty"`
}
