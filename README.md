# Exam-Final-Prog


Le tout nouveauy jeu Plummet Game de la compagnie Massive Games est un jeu qui consiste a un jeu de course à obstacle. Le joueur doit courir et éviter des obstacles en n'entrant en collision avec quoi que ce soit. Si il tombe en collision avec un mur, sa barre d'énergie diminue, et le nombre de point sera moins grand. Le score est évalué par rapport à la distance franchie et le nombre de collision eut. Le but du jeu est d'avoir le meilleur score qui est enregistré pour le comparer avec d'autre joueurs.

![Capture d’écran_16-12-2024_172437_miro com](https://github.com/user-attachments/assets/8ed885b9-e397-4d4a-8139-84ce53a2f97c)

Le score du joueur est calculé ainsi:
textScore=(textEnergieactuelle−textNombredecollisions)+textNombredemursrestants
en ajoutant les fonctions qui calcule la quantité de murs qui ont été touché (collision), le système de score de base peut ensuite déduire le score de base, qui est 1000, pour ensuite retirer des points pour chaque collision et compter ceux qui reste (pas de collision). Le score est directement implémenté sur le joueur pour avoir le score en temps réel
