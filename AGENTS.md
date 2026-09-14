# Codex SDD guidance

This file is an SDD lifecycle guidance target. Generated agent guidance is a
projection over `.fsgg/agents.yml` and readiness data; it is not a second source
of truth.

<!-- fsgg:workspace-initialization:start -->
## Workspace initialization

Before doing repository work, read `.fsgg/workspace-initialization.json`. If it is missing
or its `status` is not `initialized`, warn the user that setup is incomplete and run
`$initialize-sdd-workspace` with them. Do not guess repository, board, collaborator, or
package configuration.
<!-- fsgg:workspace-initialization:end -->
