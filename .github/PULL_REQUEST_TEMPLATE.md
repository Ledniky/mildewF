<!-- Guidelines: docs/github-guidelines.md -->

## About the PR
<!-- What did you change? -->

## Why / Balance
<!-- Discuss how this would affect game balance or explain why it was changed. Link any relevant discussions or issues. -->

## Linked issues
<!-- "Fixes #123" / "Closes #123" / "Refs #123". One per line. If none, write "None". -->

## Technical details
<!-- Summary of code changes for easier review. For AI-generated PRs, follow
.agents/rules/ss14-ai-workflow.md: for each non-trivial change, describe
WHAT it does, WHERE it lives (which _Art folder / which assembly) and why,
HOW it works (event flow, predicted vs server-authoritative, what state is
networked + Dirty'd, locale keys added), and what you deliberately did NOT
do and why. Do NOT build/run/test the project to validate — describe instead. -->

## Test plan
<!--
Describe how you tested the pull request, and how someone reviewing this PR can test it themselves.
-->

## Media
<!-- Attach media if the PR makes in-game changes (clothing, items, features, etc).
Small fixes/refactors are exempt. Media may be used in SS14 progress reports with credit. -->

## Requirements
<!-- Confirm the following by placing an X in the brackets without spaces inside (for example: [X] ): -->
- [ ] I have read and am following the [Pull Request and Changelog Guidelines](https://docs.spacestation14.com/en/general-development/codebase-info/pull-request-guidelines.html).
- [ ] I have tested this pull request and written instructions on how to test it
- [ ] I have added media to this PR or it does not require an in-game showcase.
<!-- You should understand that not following the above may get your PR closed at maintainer’s discretion -->

<<<<<<< HEAD
## Fork checklist (hakumai / ss14-art)
<!-- See AGENTS.md and .agents/rules/. Place an X in the brackets. -->
- [ ] New fork systems/components/files are in `_Art` folders, not in upstream files.
- [ ] Every line edited in an upstream file (outside `_Art`) carries a `ss14-art edit` marker (single line `// ss14-art edit`, or block `// ss14-art edit start` … `// ss14-art edit end`; `# ss14-art edit` in YAML; `<!-- ss14-art edit start -->` … `end` in XAML).
- [ ] No edits under `RobustToolbox/` (engine — escalated, not edited).
- [ ] Player interactions are predicted (logic in `Content.Shared`), replicated state is `Dirty`'d, and entities in network messages/state use `NetEntity`.
- [ ] Every player-facing string is localized (`fork-`-prefixed keys in `Resources/Locale/en-US/_Art/*.ftl`, `{Loc ...}` in XAML, locale keys for entity `name`/`description`).
- [ ] Upstream diff is minimal (prefer subscribing from `_Art` over editing upstream systems).
=======
## Disclaimers
<!-- Per contribution guidelines, all contributions which use AI must disclose that use. Mark which section(s) best describe the use of AI in this PR. If AI was not used, this section may be skipped -->
- [ ] AI was used to aid in brainstorming, testing, or debugging of systems within this PR
- [ ] AI developed assets are included as parts of this PR. These assets are identified as AI developed in the file and are listed below:
    - <!-- Add any AI generated file names here. --> 
>>>>>>> persi/server-us

## Breaking changes
<!-- List any breaking changes, including namespaces, public class/method/field changes, prototype renames; and provide instructions for fixing them.
This will be posted in #codebase-changes. -->

## GitHub Links
<!-- Adds a link to any github issue resolved by this PR. All PRs should ideally resolve for contribute to at least one issue. If no issues currently match your PR, then
you may skip this section -->
- <!-- GitHub issues are identified in markdown via #123, you may also search for the name of the issue using #issue-name -->

## Changelog
<!-- Add a Changelog entry to make players aware of new features or changes that could affect gameplay.
Make sure to read the guidelines and take this Changelog template out of the comment block in order for it to show up.
Changelog must have a :cl: symbol, so the bot recognizes the changes and adds them to the game's changelog. -->
:cl:
- add: Added fun!
- remove: Removed fun!
- tweak: Changed fun!
- fix: Fixed fun!
