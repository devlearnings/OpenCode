require 'albacore'

desc "Builds solution, runs Unit Tests"
task :default => [:build]

desc "Build the solution in .Net 4.0"
build :build do |msb|
	msb.prop 'Configuration', 'Release'
	msb.sln = "WPFDemo/WPFDemo.sln"
end
