# How-to-Open-and-Close-the-.NET-MAUI-Bottom-Sheet-Programmatically
This sample demonstrates two ways to programmatically open and close the Syncfusion .NET MAUI Bottom Sheet (SfBottomSheet):

1.Using Show() and Close() methods.

2.Using the IsOpen property.

The Bottom Sheet is triggered by tapping a ListView item and displays detailed book information. A “Close BottomSheet” button inside the sheet allows users to dismiss it.

**XAML:**

```
 <Grid >
      <Grid.BindingContext>
          <local:BookViewModel/>
      </Grid.BindingContext>
                
          <ListView ItemsSource="{Binding Books}" ItemTapped="ListView_ItemTapped" HasUnevenRows="True" >
              <ListView.ItemTemplate>
                  <DataTemplate>
                      <ViewCell>
                          <Grid ColumnDefinitions="*, 60" Padding="10">
                              <VerticalStackLayout>
                                  <Label Text="{Binding Title}" FontSize="20" FontAttributes="Bold"/>
                                  <Label Text="{Binding Description}" FontSize="14" TextColor="Gray"/>
                              </VerticalStackLayout>
                              <Label Text="{Binding Rating, StringFormat='{}{0} / 5'}" Grid.Column="1" HorizontalOptions="Center" VerticalOptions="Center"/>
                          </Grid>
                      </ViewCell>
                  </DataTemplate>
              </ListView.ItemTemplate>
          </ListView>

      <bottomSheet:SfBottomSheet x:Name="bottomSheet" ContentPadding="10" State="HalfExpanded">
          <bottomSheet:SfBottomSheet.BottomSheetContent>
              <VerticalStackLayout Spacing="5" x:Name="bottomSheetContent">
                  <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                      <Label Text="Title:" FontSize="20" FontAttributes="Bold"/>
                      <Label Text="{Binding Title}" FontSize="16" VerticalTextAlignment="Center" Grid.Column="1"/>
                  </Grid>
                  <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                      <Label Text="Genre:" FontSize="20" FontAttributes="Bold"/>
                      <Label Text="{Binding Genre}" FontSize="16" VerticalTextAlignment="Center" Grid.Column="1"/>
                  </Grid>
                  <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                      <Label Text="Published:" FontSize="20" FontAttributes="Bold"/>
                      <Label Text="{Binding Published}" FontSize="16" VerticalTextAlignment="Center" Grid.Column="1"/>
                  </Grid>
                  <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                      <Label Text="Description:" FontSize="20" FontAttributes="Bold"/>
                      <Label Text="{Binding Description}" FontSize="16" VerticalTextAlignment="Center" Grid.Column="1"/>
                  </Grid>
                  <Grid ColumnDefinitions="120, *" ColumnSpacing="10">
                      <Label Text="Price:" FontSize="20" FontAttributes="Bold"/>
                      <Label FontSize="16" VerticalTextAlignment="Center" Grid.Column="1">
                          <Label.FormattedText>
                              <FormattedString>
                                  <Span Text="$" FontAttributes="Bold" />
                                  <Span Text="{Binding Price, StringFormat='{0:F2}'}" />
                              </FormattedString>
                          </Label.FormattedText>
                      </Label>
                  </Grid>
                  <Button Text="Close BottomSheet" Clicked="CloseBottomSheet" Margin="0,10,0,0" WidthRequest="200"></Button>
              </VerticalStackLayout>
          </bottomSheet:SfBottomSheet.BottomSheetContent>
      </bottomSheet:SfBottomSheet>

  </Grid>
```
**if you are using IsOpen Property to Open and close the BottomSheet**

**C#**
```
private void ListView_ItemTapped(object? sender, ItemTappedEventArgs e)
{
    bottomSheet.BottomSheetContent.BindingContext = e.Item;
    bottomSheet.IsOpen = true;
}

private void CloseBottomSheet(object sender, EventArgs e)
{
    bottomSheet.IsOpen = false;
}
```

**If you are using the Show() and Close() methods to control the BottomSheet**

**C#**

```
private void ListView_ItemTapped(object? sender, ItemTappedEventArgs e)
{
    bottomSheet.BottomSheetContent.BindingContext = e.Item;
    bottomSheet.Show();
}

private void CloseBottomSheet(object sender, EventArgs e)
{
    bottomSheet.Close();
}
```
