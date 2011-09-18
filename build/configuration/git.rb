configs ={
  :git => {
    :user => 'dwpdaxko',
    :remotes => potentially_change("remotes",__FILE__),
    :repo => 'prep' 
  }
}
configatron.configure_from_hash(configs)
