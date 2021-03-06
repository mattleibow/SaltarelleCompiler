﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NodeJS.BufferModule;

namespace NodeJS.ChildProcessModule {
	[Imported]
	[GlobalMethods]
	[ModuleName("child_process")]
	public static class ChildProcess {
		public static ChildProcessInstance Spawn(string command) { return null; }

		public static ChildProcessInstance Spawn(string command, string[] args) { return null; }

		public static ChildProcessInstance Spawn(string command, string[] args, SpawnOptions options) { return null; }


		public static ChildProcessInstance Exec(string command) { return null; }

		public static ChildProcessInstance Exec(string command, Action<Error, Buffer, Buffer> callback) { return null; }

		public static ChildProcessInstance Exec(string command, ExecOptions options, Action<Error, Buffer, Buffer> callback) { return null; }

		[InlineCode("{$System.Threading.Tasks.Task}.fromNode({$NodeJS.ChildProcessModule.ChildProcess}, function(a, b) {{ return {{ stdout: a, stderr: b}}; }}, 'exec', {command})")]
		public static Task<ChildProcessHandles> ExecTask(string command) { return null; }

		[InlineCode("{$System.Threading.Tasks.Task}.fromNode({$NodeJS.ChildProcessModule.ChildProcess}, function(a, b) {{ return {{ stdout: a, stderr: b}}; }}, 'exec', {command}, {options})")]
		public static Task<ChildProcessHandles> ExecTask(string command, ExecOptions options) { return null; }


		public static ChildProcessInstance ExecFile(string file, string[] args) { return null; }

		public static ChildProcessInstance ExecFile(string file, ExecOptions options) { return null; }

		public static ChildProcessInstance ExecFile(string file, string[] args, ExecOptions options) { return null; }

		public static ChildProcessInstance ExecFile(string file, string[] args, Action<Error, Buffer, Buffer> callback) { return null; }

		public static ChildProcessInstance ExecFile(string file, ExecOptions options, Action<Error, Buffer, Buffer> callback) { return null; }

		public static ChildProcessInstance ExecFile(string file, string[] args, ExecOptions options, Action<Error, Buffer, Buffer> callback) { return null; }

		[InlineCode("{$System.Threading.Tasks.Task}.fromNode({$NodeJS.ChildProcessModule.ChildProcess}, function(a, b) {{ return {{ stdout: a, stderr: b}}; }}, 'execFile', {file}, {args})")]
		public static Task<Tuple<Buffer, Buffer>> ExecFileTask(string file, string[] args) { return null; }

		[InlineCode("{$System.Threading.Tasks.Task}.fromNode({$NodeJS.ChildProcessModule.ChildProcess}, function(a, b) {{ return {{ stdout: a, stderr: b}}; }}, 'execFile', {file}, {options})")]
		public static Task<Tuple<Buffer, Buffer>> ExecFileTask(string file, ExecOptions options) { return null; }

		[InlineCode("{$System.Threading.Tasks.Task}.fromNode({$NodeJS.ChildProcessModule.ChildProcess}, function(a, b) {{ return {{ stdout: a, stderr: b}}; }}, 'execFile', {file}, {args}, {options})")]
		public static Task<Tuple<Buffer, Buffer>> ExecFileTask(string file, string[] args, ExecOptions options) { return null; }


		public static ChildProcessInstance Fork(string modulePath) { return null; }

		public static ChildProcessInstance Fork(string modulePath, string[] args) { return null; }

		public static ChildProcessInstance Fork(string modulePath, ForkOptions options) { return null; }

		public static ChildProcessInstance Fork(string modulePath, string[] args, ForkOptions options) { return null; }

	}
}
