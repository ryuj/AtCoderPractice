def main
    return if ARGV.empty?
    
    file = ARGV[0]
    cmd = "mcs #{file}.cs && mono #{file}.exe"

    puts cmd
    system cmd
end

main
