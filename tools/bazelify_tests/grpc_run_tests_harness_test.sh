#!/bin/bash
# Copyright 2023 The gRPC Authors
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http://www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

set -ex

if [ "${GRPC_RUNTESTS_USE_LOGIN_SHELL}" != "" ]
then
  unset GRPC_RUNTESTS_USE_LOGIN_SHELL
  # respawn the entire script using login shell
  exec bash -l "$0" "$@"
fi

ARCHIVE_WITH_SUBMODULES="$1"
shift

# The JUnit XML report file generated by run_tests.py is compatible with
# the report format accepted by bazel as the result for tests target.
REPORT_XML_FILE="${XML_OUTPUT_FILE}"
# Create report suite name from the last component of the bazel target's name.
REPORT_SUITE_NAME="$(echo ${TEST_TARGET} | sed 's|^.*[:/]||')"

# Extract grpc repo archive
tar -xopf ${ARCHIVE_WITH_SUBMODULES}
cd grpc

if [ "${GRPC_RUNTESTS_PREPARE_SCRIPT}" != "" ]
then
  source "../${GRPC_RUNTESTS_PREPARE_SCRIPT}"
fi

python3 tools/run_tests/run_tests.py -t -j "$(nproc)" -x "${REPORT_XML_FILE}" --report_suite_name "${REPORT_SUITE_NAME}" "$@" || FAILED="true"

if [ -x "$(command -v ccache)" ]
then
  ccache --show-stats || true
fi

if [ "$FAILED" != "" ]
then
  exit 1
fi

