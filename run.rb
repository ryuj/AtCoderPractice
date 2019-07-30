def main
    ary = File.open("target").to_a
    file = ary[0]
    cmd = "mcs #{file}.cs && mono #{file}.exe"

    puts cmd
    system cmd
end

main
