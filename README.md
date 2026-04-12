# Interview Prep - Problem Solving Tasks

This repository is a long-term collection of problem-solving practice for technical interviews.

Each interview preparation cycle is maintained in its own versioned branch so progress stays organized and historical prep rounds are easy to revisit.

## Branch Versioning Convention

Use this branch format for every prep cycle:

```text
V<version>/<Mon>/<YYYY>
```

Examples:

- `V1/Apr/2026`
- `V2/Jul/2028`
- `V3/Jan/2029`

Branch naming rules:

- Increment version number (`V1`, `V2`, `V3`, ... ) for each new interview prep cycle.
- Use 3-letter month format (`Jan`, `Feb`, `Mar`, ... ).
- Use 4-digit year (`2026`, `2028`, ... ).

## What Each Version Branch Should Contain

- Problem statements
- Solution approaches (brute force and optimized where possible)
- Time and space complexity notes
- Edge cases and test scenarios
- Key takeaways and interview talking points

## Suggested Structure (Inside Each Version Branch)

```text
arrays/
strings/
linked-list/
stack-queue/
trees/
graphs/
dynamic-programming/
greedy/
notes/
```

You can store each problem as a markdown file or language-specific source file, depending on your workflow.

## Typical Workflow

1. Start from latest `main`.
2. Create a new prep branch using the version format.
3. Add problems topic by topic.
4. Commit changes regularly.
5. Keep previous prep branches unchanged as historical snapshots.

Example:

```bash
git checkout main
git pull
git checkout -b V1/Apr/2026
```

## Goal

Build a consistent, versioned archive of interview problem-solving practice that can be reused, reviewed, and improved over time.
